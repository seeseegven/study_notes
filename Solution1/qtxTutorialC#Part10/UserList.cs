using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qtxTutorialC_Part10
{
    internal class UserList
    {
        private  User[] users = null;
        private int Capacity{get; set;}
        public int count = 0;
        public UserList(int capacity)
        {
            users = new User[capacity];
            Capacity = capacity;
        }
        public UserList():this(10){ }//不输入长度，默认为10

        public void Add(User value)
        {
            if (count >= Capacity)//扩容
            {
                Capacity *= 2;
                User[] newUsers = new User[Capacity];
                for (int i=0;i < count;i++)
                {
                    newUsers[i] = users[i];
                }
                users = newUsers;
            }
            users[count++] = value;
            
        }

        public User Get(int index)
        {
            return users[index];
        }
    }

    internal class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
