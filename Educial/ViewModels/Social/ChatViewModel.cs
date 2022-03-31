using Models.Social;
using Models.User;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;


namespace Educial.ViewModels.Social
{
    internal class ChatViewModel : BaseViewModel
    {
        public ObservableCollection<Conversation> Conversations { get; set; }

        public ChatViewModel()
        {
            Title = "Chats";
            Conversations = new ObservableCollection<Conversation>(new List<Conversation>());
            ConversationTapCommand = new AsyncCommand<Conversation>(ConversationTapped);
            InitData();
        }
        public AsyncCommand<Conversation> ConversationTapCommand { get; set; }
        private static async Task ConversationTapped(Conversation conversation)
        {
            if (conversation == null) return;
            await Application.Current.MainPage.DisplayAlert("Favorite", conversation.LastMessage.Content,
                "OK");
        }

        public void AddNewItem()
        {
            Conversations.Add(new Conversation
            {
                LastMessage = new Message
                {
                    Content = "আনসান!",
                    IsSent = false

                },
                CreationDate = DateTime.Parse("01:11 AM 2-13-2022"),
                Peer = new Student
                {
                    FirstName = "Ashiqur",
                    LastName = "Rahman Alif",
                    ProfilePic = "alif.jpg"
                }

            });
        }
        private void InitData()
        {
            /*_ = Task.Run(() =>*/
            var conversations = new List<Conversation>
            {
                new Conversation
                {
                    LastMessage = new Message
                    {
                        Content = "Kal class hobe na. \"Stop setting $CARGO_HOME to its default value\"",
                        IsSent = false

                    },
                    CreationDate = DateTime.Parse("01:11 AM 2-13-2022"),
                    Peer = new Student
                    {
                        FirstName = "Ashiqur",
                        LastName = "Rahman Alif",
                        ProfilePic = "alif.jpg"
                    }

                },
                new Conversation
                {
                    LastMessage = new Message {Content = "Pala bota 🥱"},
                    CreationDate = DateTime.Parse("01:00 AM 2-13-2022"),
                    Peer = new Student
                    {
                        FirstName = "Nagib",
                        LastName = "Akib",
                        ProfilePic = "akib.jpg"
                    }
                },
                new Conversation
                {
                    LastMessage = new Message {Content = "Oek", IsSent = true},
                    CreationDate = DateTime.Parse("00:11 AM 2-13-2022"),
                    Peer = new Student
                    {
                        FirstName = "Mahfuz",
                        LastName = "Arnob",
                        ProfilePic = "arnob.jpg"
                    }
                },
                new Conversation
                {
                    LastMessage = new Message {Content = "Ok vai"},
                    CreationDate = DateTime.Parse("11:11 PM 2-12-2022"),
                    Peer = new Student
                    {
                        FirstName = "Hult Prize",
                        LastName = "at VU",
                        ProfilePic = "hult.jpg"
                    }
                },
                new Conversation
                {
                    LastMessage = new Message {Content = "Wordle 239 4/6"},
                    CreationDate = DateTime.Parse("01:11 PM 2-12-2022"),
                    Peer = new Student
                    {
                        FirstName = "print(\"CSE21\")",
                        ProfilePic = "cse.jpg"
                    }
                },
                new Conversation
                {
                    LastMessage = new Message {Content = "Tui?"},
                    CreationDate = DateTime.Parse("11:11 AM 2-12-2022"),
                    Peer = new Student
                    {
                        FirstName = "Nirob",
                        ProfilePic = "nirob.jpg"
                    }
                }
            };
            foreach (Conversation conversation in conversations)
            {
                Conversations.Add(conversation);
            }
        }
    }
}