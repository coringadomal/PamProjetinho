using CommunityToolkit.Mvvm.ComponentModel;
using Projetinho.Models;
using Projetinho.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projetinho.ViewsModels
{
   public  partial class PostViewModels : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<post> posts;
        public PostService PostsService;
        public ICommand getPostsCommand { get; }

       public PostViewModels()
        {
            PostService postService = new PostService();
            getPostsCommand = new Command(getPosts);
        }

        public async void getPosts()
        {
            //Buscar os dados da API
            posts = await PostsService.GetPosts();
        }
            

     }
        
}

