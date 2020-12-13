using SpendFlix.Data.Repository;
using SpendFlix.Entities;
using System.Collections.Generic;

namespace SpendFlix.Business.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public List<PostDTO> GetPosts()
        {
            return _postRepository.GetPosts();
        }
    }
}
