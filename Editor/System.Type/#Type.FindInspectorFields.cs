// smidgens @ github

#pragma warning disable 0414

#if UNITY_EDITOR

namespace Smidgenomics.Unity.Extensions.Editor
{
	using System;
	using System.Collections.Generic;
	using UnityEngine;
	using System.Reflection;

	public static partial class _Type_
	{
		/// <summary>
		/// [Editor] Find all fields that Unity would default include in the inspector
		/// </summary>
		/// <param name="owner"></param>
		/// <typeparam name="T">Base type to stop at</typeparam>
		/// <returns></returns>
		public static IReadOnlyList<FieldInfo> FindInspectorFields<T>(this Type owner)
		{
			// NOTE: doesn't work properly for unity components, flags might need to be different

			var baseType = typeof(T);

			List<FieldInfo> fields = new List<FieldInfo>();
			LinkedList<Type> hierarchy = new LinkedList<Type>(); // linked for efficient prepend

			// traverse parent hierarchy, stop at base type
			Type currentType = owner;
			while (currentType != baseType && currentType != null)
			{
				hierarchy.AddFirst(currentType);
				currentType = currentType.BaseType;
			}

			var fieldFlags = BindingFlags.NonPublic
			| BindingFlags.Public
			| BindingFlags.DeclaredOnly
			| BindingFlags.Instance;

			// append fields in
			// same order as Unity would normally list them
			foreach (Type htype in hierarchy)
			{
				foreach (FieldInfo field in htype.GetFields(fieldFlags))
				{
					if (!IsInspectorField(field))
					{
						continue;
					}
					fields.Add(field);
				}
			}
			return fields;
		}

		// can field be drawn by inspector
		private static bool IsInspectorField(FieldInfo f)
		{
			// explicitly public but non-serialized
			if (f.IsPublic && f.IsDefined(typeof(NonSerializedAttribute)))
			{
				return false;
			}

			// explicitly hidden
			if (f.IsDefined(typeof(HideInInspector)))
			{
				return false;
			}

			// private, non serialized
			if (!f.IsPublic && !f.IsDefined(typeof(SerializeField)))
			{
				return false;
			}

			// at this point, either the field is public, or private and using SerializeField
			return true;
		}
	}
}

#endif