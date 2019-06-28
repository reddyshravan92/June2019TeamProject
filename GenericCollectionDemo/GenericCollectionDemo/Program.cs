using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericCollectionDemo
{
    public class Store<T>
    {
        private T obj;
        
        public void Initialize(T entity)
        {
            this.obj = entity;
        }

        public override string ToString()
        {
            return this.obj.ToString();
        }
    }
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{this.Id} {this.FirstName} {this.LastName}";
        }
    }

    public class DataStore<Tkey, TValue>
    {
        private Tkey tKey;
        private TValue tValue;

        public void AddData(Tkey key, TValue value)
        {
            this.tKey = key;
            this.tValue = value;
        }

        public override string ToString()
        {
            return $"{this.tKey} {this.tValue}";
        }
    }
    

    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(int id);
        List<T> GetAll();
        
    }

    public class RepositoryBase<T> : IRepository<T>
    {
        private List<T> data;
        public RepositoryBase()
        {
            data = new List<T>();
        }

        public void Add(T entity)
        {
            this.data.Add(entity);
        }

        public void Delete(T entity)
        {
            this.data.Remove(entity);
        }

        public T Get(int id)
        {
            return this.data[id];
        }

        public List<T> GetAll()
        {
            return this.data;
        }

        public void Update(T entity)
        {
            //
        }
    }


    public class Blog
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
    }

    public class Post
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string Title { get; set; }
    }

    /// <summary>
    /// This is for blog implementation
    /// </summary>
    public class BlogRepository : RepositoryBase<Blog>
    {
        //add additional methods here
    }


    /// <summary>
    /// This is for post implemenation
    /// </summary>
    public class PostRepository : RepositoryBase<Post>
    {
        //add an addtional methods
    }

    public delegate bool Expression<T>(T arg);

    public static class Utilities
    {
        public static int [] Filter(this int[] data, Expression<int> exp)
        {
            for(int i = 0; i< data.Length; i++)
            {
                if (exp(data[i]))
                {
                    data[i] = data[i] * data[i];
                }
            }
            return data;
        }

        public static int [] FilterString(this string [] names, Expression<string> exp)
        {
            int[] lengths = new int[names.Length];

            for(var i = 0; i < names.Length; i++)
            {
                if (exp(names[i]))
                {
                    lengths[i] = names[i].Length;
                }
                else
                {
                    lengths[i] = 0;
                }
            }
            return lengths;
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            //object value = "yyy788";
            //int result  = Convert.ToInt32(value);

            //ArrayList list = new ArrayList();
            //list.Add(100);
            //list.Add("satya");
            //list.Add(new Person() { Id = 100 });


            //int value = Convert.ToInt32( list[1]);
            //string result = Convert.ToString(list[2]);
            //Console.WriteLine(result);


            //Person p = new Person() { Id = 1, FirstName = "Scott", LastName = "James" };

            //Store<int> intStore = new Store<int>();
            //intStore.Initialize(100);
            //Console.WriteLine(intStore.ToString());

            //Store<string> stringStore = new Store<string>();
            //stringStore.Initialize("Satya");
            //Console.WriteLine(stringStore.ToString());


            //Store<Person> personStore = new Store<Person>();
            //personStore.Initialize(new Person() { Id = 1, FirstName = "Scott", LastName = "James" });
            //Console.WriteLine(personStore.ToString());


            //DataStore<int, string> store1 = new DataStore<int, string>();
            //store1.AddData(100, "Satya");

            //DataStore<int, Person> store2 = new DataStore<int, Person>();
            //store2.AddData(1, new Person() { });

            IRepository<Blog> blogRepo = new BlogRepository();
            blogRepo.Add(new Blog() { });
            blogRepo.Update(new Blog() { });
            blogRepo.Delete(new Blog() { });
            var blog = blogRepo.Get(0);
            List<Blog> blogs = blogRepo.GetAll();

            IRepository<Post> postRepo = new PostRepository();
            postRepo.Add(new Post() { });
            postRepo.Update(new Post() { });
            //..
            //..

            int[] arr = { 1, 2, 3, 4, 5 };

           var result1 =  arr.Filter((arg) => arg % 2 == 0);
        foreach(var item in result1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            string[] names = { "John", "Abs", "Lio", "RR" };
            var result = names.FilterString((arg) => arg == "RR" || arg == "John");
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

            List<string> nameData = new List<string>()
            {
                "John", "James", "abcd"
            };

            nameData.Add("Satya");

            if (nameData.Contains("Satya"))
            {
                Console.WriteLine("Item found");
                nameData.Remove("Satya");
            }

            nameData.RemoveAll((name) => name.Length == 4);

            Console.WriteLine("Left Names:"+ nameData.Count);


            Dictionary<int, Person> personData = new Dictionary<int, Person>();
            personData.Add(1, new Person() { Id = 1, LastName = "James", FirstName = "John" });
            personData.Add(2, new Person() { Id = 2, LastName = "Allen", FirstName = "Smith" });

            personData.Remove(1);

            IList<int> myData = new List<int>();
           
           
            
        }
    }
}
  