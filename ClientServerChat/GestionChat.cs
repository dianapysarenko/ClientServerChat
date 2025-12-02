using System;
using System.Collections.Generic;
using System.Threading;

namespace ChatClient
{
    public delegate void MessageReceivedHandler(ChatManager sender, Message message);
    public delegate void ClientDisconnectedHandler(ChatManager sender);

    public class ChatManager
    {
        // --- Champs privés ---
        private string _ip;
        private int _port;
        private string _pseudo;

        private ClientReseau _networkClient;
        private Thread _threadListener;

        private Stack<Message> _incomingMessages;

        // --- Synchronisation ---
        public Mutex MessagesLock { get; internal set; }
        public AutoResetEvent NewMessageEvent { get; internal set; }
        public AutoResetEvent ExitEvent { get; internal set; }

        // --- Événements ---
        public MessageReceivedHandler MessageReceived;
        public ClientDisconnectedHandler ClientDisconnected;

        // --- Propriétés ---
        public bool IsConnected => _networkClient != null && _networkClient.Connected;


        // --- Constructeur ---
        public ChatManager(string ipAddress, int port, string pseudo)
        {
            _ip = ipAddress;
            _port = port;
            _pseudo = pseudo;

            _incomingMessages = new Stack<Message>();
            MessagesLock = new Mutex();

            NewMessageEvent = new AutoResetEvent(false);
            ExitEvent = new AutoResetEvent(false);
        }


        // --- Démarrage du client ---
        public void Start()
        {
            _networkClient = new ClientReseau(_ip, _port);

            if (!_networkClient.Connect())
            {
                _networkClient = null;
                return;
            }

            // liaison des objets
            _networkClient.AccessMessages = MessagesLock;
            _networkClient.SignalementMessage = NewMessageEvent;
            _networkClient.SignalementSortie = ExitEvent;
            _networkClient.Messages = _incomingMessages;

            // initialisation
            _networkClient.Start();
        }

        // --- Envoi sans fichier ---
        public void Send(string text)
        {
            if (_networkClient == null) return;

            var msg = new Message(_networkClient.Id, text);
            msg.Envoi(_pseudo);

            _networkClient.Ecrire(msg.Data);
        }

        // --- Stop ---
        public void Stop()
        {
            _networkClient?.Disconnect();
        }
    }
}