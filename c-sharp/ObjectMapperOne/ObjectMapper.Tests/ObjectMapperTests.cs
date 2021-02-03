using FluentAssertions;
using ObjectMapper.Adapters;
using ObjectMapper.Models;
using System;
using Xunit;

namespace Api.Tests
{
	public class ObjectMapperTests
	{
		[Fact]
		public void Throws_Error_When_String_Is_Null()
		{
			var sut = new BlogPostSummaryAdapter();

			Action act = () => sut.ConvertDevToSummary(null);

			act.Should().Throw<ArgumentNullException>();
		}

		[Fact]
		public void Throws_Error_If_Id_Not_Filled()
		{
			var sut = new BlogPostSummaryAdapter();
			var json = $"[{{{url}, {title}, {description}, {publishedDate}}}]";

			Action act = () => sut.ConvertDevToSummary(json);

			act.Should().Throw<ArgumentException>().WithMessage("id not found in input");
		}

		[Fact]
		public void Throws_Error_If_Url_Not_Filled()
		{
			var sut = new BlogPostSummaryAdapter();
			var json = $"[{{{id}, {title}, {description}, {publishedDate}}}]";

			Action act = () => sut.ConvertDevToSummary(json);

			act.Should().Throw<ArgumentException>().WithMessage("url not found in input");
		}

		[Fact]
		public void Throws_Error_If_Title_Not_Filled()
		{
			var sut = new BlogPostSummaryAdapter();
			var json = $"[{{{url}, {id}, {description}, {publishedDate}, {coverImage}}}]";

			Action act = () => sut.ConvertDevToSummary(json);

			act.Should().Throw<ArgumentException>().WithMessage("title not found in input");
		}

		[Fact]
		public void Throws_Error_If_Description_Not_Filled()
		{
			var sut = new BlogPostSummaryAdapter();
			var json = $"[{{{url}, {id}, {title}, {publishedDate}, {coverImage}}}]";

			Action act = () => sut.ConvertDevToSummary(json);

			act.Should().Throw<ArgumentException>().WithMessage("description not found in input");
		}

		[Fact]
		public void Throws_Error_If_PublishedDate_Not_Filled()
		{
			var sut = new BlogPostSummaryAdapter();
			var json = $"[{{{url}, {id}, {title}, {description}, {coverImage}}}]";

			Action act = () => sut.ConvertDevToSummary(json);

			act.Should().Throw<ArgumentException>().WithMessage("published_at not found in input");
		}

		[Fact]
		public void Throws_Error_If_CoverImage_Not_Filled()
		{
			var sut = new BlogPostSummaryAdapter();
			var json = $"[{{{url}, {id}, {title}, {description}, {publishedDate}}}]";

			Action act = () => sut.ConvertDevToSummary(json);

			act.Should().Throw<ArgumentException>().WithMessage("cover_image not found in input");
		}

		[Fact]
		public void Return_Empty_Array_When_No_Posts()
		{
			var sut = new BlogPostSummaryAdapter();
			var json = $"[]";

			var result = sut.ConvertDevToSummary(json);
			result.Should().BeEquivalentTo(new BlogPostSummary[0]);
		}

		[Fact]
		public void Return_1_Item_When_Json_has_1_()
		{
			var sut = new BlogPostSummaryAdapter();
			var json = $"[{{{url}, {id}, {title}, {description}, {publishedDate}, {coverImage}}}]";

			var result = sut.ConvertDevToSummary(json);
			result.Should().BeEquivalentTo(new[] { validSummary });
		}

		[Fact]
		public void Return_2_Item_When_Json_has_2_()
		{
			var sut = new BlogPostSummaryAdapter();
			string objectString = $"{{{url}, {id}, {title}, {description}, {publishedDate}, {coverImage}}}";
			var json = $"[{objectString}, {objectString}]";

			var result = sut.ConvertDevToSummary(json);
			result.Should().BeEquivalentTo(new[] { validSummary, validSummary });
		}

		private const string url = @"""url"": ""This is a url""";
		private const string title = @"""title"": ""This is a title""";
		private const string description = @"""description"": ""This is a description""";
		private const string id = @"""id"": 1";
		private const string publishedDate = @"""published_at"": ""2020-05-10T08:25:00Z""";
		private const string coverImage = @"""cover_image"": ""This is a cover image""";
		private BlogPostSummary validSummary = new BlogPostSummary
		{
			BlogUrl = "This is a url",
			Description = "This is a description",
			Id = 1,
			Title = "This is a title",
			CoverImage = "This is a cover image",
			PublishedAt = new DateTime(2020, 05, 10, 08, 25, 00)
		};
	}
}
