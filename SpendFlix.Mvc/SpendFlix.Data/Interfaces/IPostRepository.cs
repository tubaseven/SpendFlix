using SpendFlix.Entities;
using System.Collections.Generic;

namespace SpendFlix.Data.Repository
{
    public interface IPostRepository
    {
        List<PostDTO> GetPosts();
    }
}
