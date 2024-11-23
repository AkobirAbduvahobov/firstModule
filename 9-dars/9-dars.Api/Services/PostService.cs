using _9_dars.Api.Models;
using System.Xml.Linq;

namespace _9_dars.Api.Services;

public class PostService
{
    private List<Post> posts;

    public PostService()
    {
        posts = new List<Post>();
    }

    public Post AddPost(Post post)
    {
        post.Id = Guid.NewGuid();
        posts.Add(post);

        return post;
    }

    public Post GetById(Guid postId)
    {
        foreach (var post in posts)
        {
            if(post.Id == postId)
            {
                return post;
            }
        }

        return null;
    }

    public Post GetMostViewedPost()
    {
        var responsePost = new Post();
        foreach (var post in posts)
        {
            if(responsePost.ViewerNames.Count < post.ViewerNames.Count)
            {
                responsePost = post;
            }
        }

        return responsePost;
    }

    public Post GetMostLikedPost()
    {

    }

    public Post GetMostCommentedPost()
    {

    }

    public List<Post> GetPostsByComment(string comment)
    {
        var responsePosts = new List<Post>();  
        
        foreach (var post in posts)
        {
            if(post.Comments.Contains(comment) is true)
            {
                responsePosts.Add(post);
            }
        }

        return responsePosts;
    }

    public bool AddCommentToPost(Guid postId, string comment)
    {
        var post = GetById(postId);

        if (post is null)
        {
            return false;
        }

        post.Comments.Add(comment);
        return true;
    }

    public bool AddViewerNameToPost(Guid postId, string viewerName)
    {
        var post = GetById(postId);

        if (post is null)
        {
            return false;
        }

        post.ViewerNames.Add(viewerName);
        return true;
    }

    public bool AddLikeToPost(Guid postId)
    {
        var post = GetById(postId);
        if (post is null)
        {
            return false;
        }
        post.QuantityLikes++;
        
        return true;
    }
}
