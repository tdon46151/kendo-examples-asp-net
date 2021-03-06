#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace OpenAccessKendoService
{
	using System;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.Serialization;
	using System.ServiceModel;
	using OpenAccessKendoService.Dto;

	[ServiceContract]
	public interface INorthwindContextService
	{
		#region Products CRUD Operations
	
		[OperationContract]
		IEnumerable<ProductDto> ReadProducts();
	
		[OperationContract]
		IEnumerable<ProductDto> ReadProductsPaged(int startIndex, int pageSize);
	
		[OperationContract]
		IEnumerable<ProductDto> ReadProductsFiltered(string sortExpression, string filterExpression);
	
		[OperationContract]
		IEnumerable<ProductDto> ReadProductsPagedAndFiltered(int startIndex, int pageSize, string sortExpression, string filterExpression);
	
		[OperationContract]
		ProductDto ReadProduct(string dtoKey);
		
		[OperationContract]
		int ProductsCount();
		
		[OperationContract]
		int ProductsCountFiltered(string filterExpression);
	
		[OperationContract]
		ProductDto CreateProduct(ProductDto product);
	
		[OperationContract]
		void UpdateProduct(ProductDto product);
	
		[OperationContract]
		void UpdateProducts(IEnumerable<ProductDto> products);
	
		[OperationContract]
		void DeleteProduct(ProductDto product);
	
		[OperationContract]
		void DeleteProducts(IEnumerable<ProductDto> products);
		
		#endregion
	}
}
#pragma warning restore 1591
