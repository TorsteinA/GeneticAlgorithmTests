using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Alvtor_Hartho_15.FSM;

namespace Tomtom.Utility
{
    public static class ReflectionHelpers
    {
//      TODO make this properly generic
        public static IEnumerable<State> GetStates()
        {
            var type = typeof(State);
            var assembly = type.Assembly;
            var subClassSet = new HashSet<State>();

            var typeList = assembly.GetTypes().Where(t => t.IsSubclassOf(type));
            foreach (var typeName in typeList)
            {
                subClassSet.Add((State) Activator.CreateInstance(typeName));
            }
            return subClassSet;
        }

    }
}