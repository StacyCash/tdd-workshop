using FluentAssertions;
using System;
using Xunit;
using ObjectMapperTwo.Adapters;

namespace ObjectMapperTwo.Tests
{
	public class BlogPostAdapterTests
	{
		[Fact]
		public void Throws_Error_When_String_Is_Null()
		{
			true.Should().BeFalse();
		}

		[Fact]
		public void Throws_Error_If_Id_Not_Filled()
		{
			true.Should().BeFalse();
		}

		[Fact]
		public void Throws_Error_If_Slug_Not_Filled()
		{
			true.Should().BeFalse();
		}

		[Fact]
		public void Throws_Error_If_Date_Not_Filled()
		{
			true.Should().BeFalse();
		}

		[Fact]
		public void Throws_Error_If_Url_Not_Filled()
		{
			true.Should().BeFalse();
		}

		[Fact]
		public void WhenExcerptIsFilled_ReturnPostWithExcerpt()
		{
			true.Should().BeFalse();
		}

		[Fact]
		public void WhenExcerptIsNotFilled_ReturnPostWithoutExcerpt()
		{
			true.Should().BeFalse();
		}

		[Fact]
		public void WhenContentIsFilledWith_Data_Orig_File_Tag_Should_ReturnUrlToPicture()
		{
			true.Should().BeFalse();
		}

		[Fact]
		public void WhenContentIsNotFilled_PostIsNotReturned()
		{
			true.Should().BeFalse();
		}

		[Fact]
		public void WhenNoImageUrl_PostIsNotReturned()
		{
			true.Should().BeFalse();
		}

		private string content = "\"content\": \"<p><img loading =\\\"lazy\\\" data-attachment-id=\\\"2152\\\" data-permalink=\\\"https://picturesinpassing.wordpress.com/img_20190627_231214/\\\" data-orig-file=\\\"https://picturesinpassing.files.wordpress.com/2019/06/img_20190627_231214.jpg\\\" data-orig-size=\\\"5120,3840\\\"";
		private string slug = "\"slug\": \"thats-a-lot-of-people\"";
		private string id = "\"ID\": 2153";
		private string date = "\"date\": \"2019-06-28T13:12:59+00:00\"";
		private string url = "\"URL\": \"https://picturesinpassing.wordpress.com/2019/06/28/thats-a-lot-of-people/\"";
		private string excertp = "\"excerpt\": \"<p>Some text to go with the post</p>\n\"";
	}
}
