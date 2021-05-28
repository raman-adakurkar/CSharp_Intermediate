/*Design a class called Post.This class models a StackOverflow post. It should have properties
for title, description and the date/time it was created. We should be able to up-vote or down-vote
a post. We should also be able to see the current vote value. In the main method, create a post,
up-vote and down-vote it a few times and then display the the current vote value.*/

using System;

namespace exercise2
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _dateTime;
        private int _voteCount = 0;

        public void CreatePost(string title, string description)
        {
            _title = title;
            _description = description;
            _dateTime = DateTime.Now;

            Console.WriteLine("Title : " + _title + "\nDescription : " + _description + "\nCreated on : " + _dateTime);
            
        }

        public int UpVote()
        {
            return _voteCount++;
        }

        public int DownVote()
        {
            return _voteCount--;
        }

        public int VoteCount()
        {
            return _voteCount;
        }

    }
}
