using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Esedra
{
    public class EsedraContainer
    {
        /// <summary>
        /// Dictionary with all 
        /// </summary>
        private Dictionary<Type, Type> dependencyMap = new Dictionary<Type, Type>();

        /// <summary>
        /// Resolve all dependencies and inject an object
        /// </summary>
        /// <typeparam name="T">Object type to be injected</typeparam>
        /// <returns>An instance of the required type</returns>
        public T Inject<T>()
        {
            return (T)resolve(typeof(T));
        }

        /// <summary>
        /// Resolve all dependencies in the costructor with a recursive method for each constructor parameters
        /// </summary>
        /// <param name="typeToResolve">A given type to resolve</param>
        /// <returns>Object resolved</returns>
        private object resolve(Type typeToResolve)
        {
            //All parameters in the typeToResolve first constructor
            IList<object> parameters = new List<object>();
            try
            {
                //Get the type, mapped before, in which it must resolved to
                Type resolvedType = dependencyMap[typeToResolve];

                //Get first costructor of the resolvedType
                ConstructorInfo constructor = resolvedType.GetConstructors().First();
                //Get all constructor's parameters
                ParameterInfo[] constructorParameters = constructor.GetParameters();

                if (constructorParameters.Count() == 0)
                { //First costructor has zero parameters, so there's no need to resolve other dependencies
                    return Activator.CreateInstance(resolvedType); //Activator create an instance of the object
                }
                else
                {
                    //First costructor has more than zero parameters, 
                    //so we need to resolve all dependencies until the last lift of the tree
                    foreach (ParameterInfo parameter in constructorParameters)
                    {
                        parameters.Add(
                            resolve(parameter.ParameterType) //call resolve method recursively
                            );
                    }

                    return constructor.Invoke(parameters.ToArray()); //Invoke instance an object with a reflected costructor
                }
            }
            catch
            {
                throw new Exception(string.Format("Impossible to resolve type {0}", typeToResolve.FullName));
            }
        }

        /// <summary>
        /// Register a dependency. typeFrom will be resolved in typeTo.
        /// </summary>
        /// <typeparam name="Tfrom">Type from</typeparam>
        /// <typeparam name="Tto">Type to</typeparam>
        public void register<Tfrom, Tto>()
        {
            dependencyMap.Add(typeof(Tfrom), typeof(Tto));
        }
    }
}
