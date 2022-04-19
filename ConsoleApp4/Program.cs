using ConsoleApp4.DAL;
using ConsoleApp4.Data;
using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Post post = new Post();
            //post.Title = "salam";
            //post.Content = "Naber hocam";
            Connect connect = new Connect();
            //connect.Posts.Add(post);
            //connect.SaveChanges();
            //var dpt = connect.Posts.Find(1);
            //dpt.Title = "SALAMSALAM1";
            //connect.SaveChanges();
            //var find = connect.Posts.FirstOrDefault(x => x.Id == 2);
            //connect.Posts.Remove(find);
            //Console.WriteLine($"{ find}Obyekt basari ile silindi");
            //connect.SaveChanges();
            var All = connect.Posts.OrderBy(x => x.Title).ToList();
            foreach (var item in All)
            {
                Console.WriteLine(item.Content);
            }
            
        }
    }
}
