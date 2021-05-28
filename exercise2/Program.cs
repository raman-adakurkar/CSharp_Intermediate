/*Design a class called Post.This class models a StackOverflow post. It should have properties
for title, description and the date/time it was created. We should be able to up-vote or down-vote
a post. We should also be able to see the current vote value. In the main method, create a post,
up-vote and down-vote it a few times and then display the the current vote value.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Title : ");
            var title = Console.ReadLine();

            Console.WriteLine("Enter Description : ");
            var description = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var post = new Post();
            post.CreatePost(title, description);

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();

            Console.WriteLine("Current Vote Value : " + post.VoteCount());

        }
    }
}
