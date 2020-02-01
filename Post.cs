using System;

namespace EasyJekyll
{


	public class Post
	{
		String date;//format 2019-09-13
		/*String title;
		String subtitle;
		String author;
		String image;
		String permalink;
		String canonicalURL;
		String categories;
		String redirectForm;
		String featured;
		String textPost;*/
		String[,] attributes;
		int nbAttributes;
		public Post()
		{/*
		date="2019-09-13";//format 2019-09-13
		title="title";
		subtitle="subtitle";
		author="author";
		image="link title image";
		permalink="";
		canonicalURL="";
		categories="catergories";
		redirectForm="";
		featured="no";

		textPost="Post place holder";
		*/
			nbAttributes = 13;
			attributes = new String[nbAttributes][2] {
			{ "date", "2019-09-13" },
			{ "layout", "post"},
			{ "title" , "title" },
			{ "subtitle" , "subtitle" },
			{ "author" , "author" },
			{ "image" , "link title image"},
			{ "permalink" , "link"},
			{ "canonical_url" , "www.url.com"},
			{ "categories" , "[categories]" },
			{ "redirectForm" , "oldpost" },
			{ "featured" , "no" },
			{ "comments" , "true" },
			{ "textPost" , "Post \nplace \nholder"}
		};

		}



		public void exportToFile()
		{

			System.IO.File.WriteAllText(@"G:\projet\c#\easyJekyll\" + attributes[0][1] + "-title.md", fusion());
		}

		String fusion()
		{
			String fusion;
			String separater = "---\n";
			fusion = separater;
			for (int i = 1; i < nbAttributes - 1; i++)
			{
				fusion = fusion + attributes[i][0] + ": " + attributes[i][1] + "\n";

			}
			fusion = fusion + separater;
			fusion = fusion + attributes[nbAttributes - 1][1];

			return fusion;
		}

	}
}