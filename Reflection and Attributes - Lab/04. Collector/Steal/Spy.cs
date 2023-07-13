using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string nameOfClass, string[] namesOfFields)
        {
            Type classType = Type.GetType(nameOfClass);
            FieldInfo[] fieldsInfo = classType.GetFields((BindingFlags)60);
            StringBuilder sb = new StringBuilder();

            object classInstance = Activator.CreateInstance(classType, new object[] { });

            sb.AppendLine($"Class under investigation: {classType.Name}");
            foreach (FieldInfo field in fieldsInfo)
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classType)}");
            }

            return sb.ToString().TrimEnd();
        }

        public string AnalyzeAccessModifiers(string className)
        {
            Type type = Type.GetType(className);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public| BindingFlags.NonPublic);
            StringBuilder sb = new StringBuilder();
            foreach (MethodInfo method in methods.Where(m => m.Name.StartsWith ("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }

            foreach (MethodInfo method in methods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }




            return sb.ToString().TrimEnd();
        }
    }
}
