using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

public class ClientReseau
{
    private TcpClient _client;
    private NetworkStream _stream;
    private Thread _threadReception;
    private IPEndPoint _endpoint;

    // Synchronisation & stockage
    public Mutex MutexMessages { get; internal set; }
    public AutoResetEvent MessageRecuSignal { get; internal set; }
    public AutoResetEvent FermetureSignal { get; internal set; }
    public Stack<Message> FileMessages { get; internal set; }

    public int ClientId { get; internal set; }
    public bool EstConnecte { get; private set; }
    public bool EnEcoute { get; private set; }

    public ClientReseau()
    {
        EstConnecte = false;
        EnEcoute = false;
    }

    public ClientReseau(string adresseIp, int port) : this()
    {
        // Conversion de l'adresse
        var parties = adresseIp.Split('.');
        if (parties.Length != 4)
            throw new ArgumentException("L'adresse IP doit comporter 4 parties.");

        byte[] ipBytes = new byte[4];
        for (int i = 0; i < 4; i++)
        {
            ipBytes[i] = byte.Parse(parties[i]);
        }

        IPAddress ipAddress = new IPAddress(ipBytes);
        _endpoint = new IPEndPoint(ipAddress, port);
    }

    public bool Connecter()
    {
        _client = new TcpClient();

        try
        {
            _client.Connect(_endpoint);
            EstConnecte = _client.Connected;

            if (EstConnecte)
                _stream = _client.GetStream();
        }
        catch
        {
            EstConnecte = false;
        }

        return EstConnecte;
    }

         public void Deconnecter()
    {
        if (EstConnecte)
        {
            _stream?.Close();
        }
    }

    public void Demarrer()
    {
        _threadReception = new Thread(EcouterServeur);
        _threadReception.Start();
    }

    private void EcouterServeur()
    {
        EnEcoute = true;

        byte[] tampon = new byte[6_000_000];
        int taille;

        while (true)
        {
            taille = 0;

            try
            {
                taille = _stream.Read(tampon, 0, tampon.Length);
            }
            catch
            {
                break; // Erreur socket → on arrête
            }

            if (taille == 0)
                break; // Déconnecté côté serveur

            // Convertir en texte
            string brut = Encoding.ASCII.GetString(tampon, 0, taille);

            // Stockage thread-safe
            MutexMessages.WaitOne();
            MutexMessages.ReleaseMutex();

            // Signaler un nouveau message
            MessageRecuSignal.Set();
        }

        EnEcoute = false;
        FermetureSignal.Set();
    }
    public void Envoyer(string texte)
    {
        if (!EnEcoute) return;

        byte[] data = Encoding.ASCII.GetBytes(texte);
        _stream.Write(data, 0, data.Length);
    }
}