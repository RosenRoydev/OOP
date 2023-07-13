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
            FieldInfo[] fields =  type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            MethodInfo[] publicMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            MethodInfo[] privateMethods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            StringBuilder sb = new StringBuilder();

            foreach (FieldInfo field in fields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            foreach (MethodInfo method in publicMethods)
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }
            foreach (MethodInfo method in privateMethods)
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }


            return sb.ToString().TrimEnd();
        }
    }
}
