﻿using System;
using System.Diagnostics;

namespace ConsoleAppForDotnet6
{
	class Person
	{
		public string IDCode { get; private set; }
		public Person(string idCode)
		{
			this.IDCode = idCode;
		}
		public override bool Equals(object obj)
		{
			return IDCode == (obj as Person).IDCode;
		}
	}

	class Program
	{
		static void ValueTypeOPEquals()
		{
			int i = 1;
			int j = 1;

			//True
			Console.WriteLine(i == j);

			j = i;

			//True
			Console.WriteLine(i == j);
		}

		static void ReferenceTypeOPEquals()
		{
			object a = 1;
			object b = 1;

			//False
			Console.WriteLine(a == b);

			b = a;
			//True
			Console.WriteLine(a == b);
		}

		static void ValueTypeEquals()
		{
			int i = 1;
			int j = 1;

			//True
			Console.WriteLine(i.Equals(j));

			j = i;

			// True
			Console.WriteLine(i.Equals(j));
		}

		static void ReferenceTypeEquals()
		{
			object a = new Person("NB123");
			object b = new Person("NB123");

			//False
			Console.WriteLine(a.Equals(b));

			b = a;
			//True
			Console.WriteLine(a.Equals(b));
		}



		static void Main(string[] args)
		{
			ReferenceTypeEquals();

			君 先帝 = new 君();
			先帝.名称 = "先帝";
			先帝.创业(0.49);

			国 益州 = new 国();
			益州.国运 = 气候.疲弊;

			Console.WriteLine("此诚危急存亡之秋也！");

			侍中 郭攸之 = new 侍中();
			郭攸之.名称 = "郭攸之";
			if (郭攸之.追先帝之殊遇() && 郭攸之.报之于陛下())
			{
				郭攸之.不懈于内();
			}

			侍中 费祎 = new 侍中();
			费祎.名称 = "费祎";
			if (费祎.追先帝之殊遇() && 费祎.报之于陛下())
			{
				费祎.不懈于内();
			}

			侍郎 董允 = new 侍郎();
			董允.名称 = "董允";
			if (董允.追先帝之殊遇() && 董允.报之于陛下())
			{
				董允.不懈于内();
			}

			中都督 向宠 = new 中都督();
			向宠.名称 = "向宠";
			if (向宠.追先帝之殊遇() && 向宠.报之于陛下())
			{
				向宠.忘身于外();
			}

			君 陛下 = new 君();
			if (陛下.为君 == 王道.明)
			{
				陛下.开张圣听();
				陛下.恢弘志士之气();
			}
			else
			{
				陛下.宾自菲薄();
				陛下.引喻失义();
			}

			陛下.治国();

			bool 宫中 = false;
			bool 府中 = false;
			bool 陟臧 = false;
			bool 罚否 = false;
			Debug.Assert(宫中 == 府中);
			Debug.Assert(陟臧 == 罚否);

			侍卫之臣 作奸犯科者 = new 侍卫之臣();
			作奸犯科者.为臣 = 臣德.奸;
			侍卫之臣 为忠善者 = new 侍卫之臣();
			为忠善者.为臣 = 臣德.贤;
			if (陛下.为君 == 王道.明)
			{
				益州.付诸有司论其刑赏(作奸犯科者);
				益州.付诸有司论其刑赏(为忠善者);
			}
			else
			{
				陛下.偏私();
			}

			if (郭攸之.为臣 == 臣德.贤
				&& 费祎.为臣 == 臣德.贤
				&& 董允.为臣 == 臣德.贤)
			{
				Console.WriteLine("此皆良实，志虑忠纯，是以先帝简拔以遗陛下。");
			}

			string 宫中之事 = null;
			if (陛下.咨之(宫中之事)
				&& 郭攸之.谋事(宫中之事)
				&& 费祎.谋事(宫中之事)
				&& 董允.谋事(宫中之事))
			{

				陛下.施行(宫中之事);
				Console.WriteLine("裨补阙病, 有所广益");
			}

			if (向宠.为臣 == 臣德.贤)
			{
				Console.WriteLine("性行淑均，晓畅军事。");
				Console.Write("先帝称之曰：");
				先帝.曰("能");
				Console.WriteLine("是以众议举宠为督。");
			}

			string 营中之事 = null;
			if (陛下.咨之(营中之事))
			{
				陛下.施行(营中之事);
				Console.WriteLine("行阵和睦，优劣得所！");
			}

			君 文景 = new 君();
			君 恒灵 = new 君();
			国 先汉 = new 国();
			国 后汉 = new 国();

			文景.亲贤臣远小人();
			先汉.国运 = 气候.兴隆;
			恒灵.亲小人远贤臣();
			后汉.国运 = 气候.倾颓;

			do
			{
				先帝.每与臣论此事();
			} while (先帝.在);

			if (郭攸之.为臣 == 臣德.贤
					&& 费祎.为臣 == 臣德.贤
					&& 董允.为臣 == 臣德.贤)
			{
				Console.WriteLine("此悉贞良死节之臣，愿陛下亲之信之，则汉室之隆，可计日而待也。");
			}

			丞相 诸葛亮 = new 丞相();
			诸葛亮.回首往事();
			诸葛亮.表忠心();
			诸葛亮.请战(); // 此臣所以报先帝而忠陛下之职分也
			诸葛亮.道别();

		}
	}


}


