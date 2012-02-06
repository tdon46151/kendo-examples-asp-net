#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace OpenAccessKendoService.Converters
{
	using System;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.Serialization;
	using Telerik.OpenAccess;
	using System.ComponentModel;
	using System.Text.RegularExpressions;

	public class KeyUtility
	{
	    private static KeyUtility instance;
	    public static KeyUtility Instance
	    {
	        get
	        {
	            if (KeyUtility.instance == null)
	            {
	                KeyUtility.instance = new KeyUtility();
	            }
	            return KeyUtility.instance;
	        }
	        set
	        {
	            KeyUtility.instance = value;
	        }
	    }
	
	    public virtual string Convert(ObjectKey key)
	    {
            // Mapping the DtoKey to the actual value of the key

	        //TypeConverter converter = TypeDescriptor.GetConverter(typeof(ObjectKey));
	        //return converter.ConvertTo(key, typeof(string)).ToString();

            return key.ObjectKeyValues.First().Value.ToString();
	    }
	
	    public virtual ObjectKey Convert<T>(string key)
	    {
	        try
		    {
		        if (Regex.IsMatch(key, @"\[.*?\](,\[.*?\])?|.?=.?"))
		        {
		            TypeConverter converter = TypeDescriptor.GetConverter(typeof(ObjectKey));
		            ObjectKey objectKey = converter.ConvertFrom(key) as ObjectKey;
		            objectKey.TypeName = typeof(T).FullName;
		            return objectKey;
		        }
		        else
		        {
		            return new ObjectKey(typeof(T).FullName, key);
		        }
		    }
		    catch (Exception ex)
		    {
		        throw new InvalidOperationException(string.Format("An object key cannot be resolved from string {0}", key), ex);
		    }
	    }
	
	    public virtual ObjectKey Create(object entity)
	    {
	        return ObjectKey.Create(entity);
	        // If need to pass versioning information back and forth 
	        // you can use the following method to create an ObjectKey.
	        //return ObjectKey.CreateWithVersion(entity);
	    }
	}
	
}
#pragma warning restore 1591