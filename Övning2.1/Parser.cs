using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2._1
{
    class Parser
    {
        public static T Parse<T>(string input) where T : IConvertible
        {
            switch (Type.GetTypeCode(typeof(T)))
            {
                case TypeCode.Int32:
                    try
                    {
                        return (T)Convert.ChangeType(int.Parse(input), typeof(T));
                    }
                    catch (System.Exception)
                    {
                        return default(T);
                    }

                case TypeCode.Single:
                    try
                    {
                        return (T)Convert.ChangeType(float.Parse(input), typeof(T));
                    }
                    catch (System.Exception ex)
                    {
                        return default(T);
                    }

                default:
                    return default(T);
            }
        }
    }
}
