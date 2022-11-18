using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao_Singleton
{
    public sealed class SingletonGenerics<T> where T : class, new()
    {
        private static T instance;

        public static T Instance()
        {
            lock (typeof(T))
            {
                if(instance == null)
                {
                    instance = new T();
                }
                return instance;
            }
        }

    }
}
