using FluentAssertions;
using System;
using Xunit;

namespace Api.Tests
{
	public class ObjectMapperTests
	{
		[Fact]
		public void Throws_Error_When_String_Is_Null()
		{
		}

		[Fact]
		public void Throws_Error_If_Id_Not_Filled()
		{
		}

		[Fact]
		public void Throws_Error_If_Url_Not_Filled()
		{
		}

		[Fact]
		public void Throws_Error_If_Title_Not_Filled()
		{
		}

		[Fact]
		public void Throws_Error_If_Description_Not_Filled()
		{
		}

		[Fact]
		public void Throws_Error_If_PublishedDate_Not_Filled()
		{
		}

		[Fact]
		public void Throws_Error_If_CoverImage_Not_Filled()
		{
		}

		[Fact]
		public void Return_Empty_Array_When_No_Posts()
		{
		}

		[Fact]
		public void Return_1_Item_When_Json_has_1_()
		{
		}

		[Fact]
		public void Return_2_Item_When_Json_has_2_()
		{
		}

		private const string url = @"""url"": ""This is a url""";
		private const string title = @"""title"": ""This is a title""";
		private const string description = @"""description"": ""This is a description""";
		private const string id = @"""id"": 1";
		private const string publishedDate = @"""published_at"": ""2020-05-10T08:25:00Z""";
		private const string coverImage = @"""cover_image"": ""This is a cover image""";
	}
}
