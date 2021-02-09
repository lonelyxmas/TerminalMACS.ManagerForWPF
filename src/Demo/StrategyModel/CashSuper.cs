﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModel
{
	/// <summary>
	/// 现金收费抽象类
	/// </summary>
	abstract class CashSuper
	{
		/// <summary>
		/// 收取现金，参数为原价，返回为当前价
		/// </summary>
		/// <param name="money"></param>
		/// <returns></returns>
		public abstract double AcceptCash(double money);
	}

	/// <summary>
	/// 正常收费子类
	/// </summary>
	class CashNormal : CashSuper
	{
		/// <summary>
		/// 正常收费，原价返回
		/// </summary>
		/// <param name="money"></param>
		/// <returns></returns>
		public override double AcceptCash(double money)
		{
			return money;
		}
	}

	/// <summary>
	/// 打折收费子类
	/// </summary>
	class CashRebate : CashSuper
	{
		private double moneyRebate = 1d;

		/// <summary>
		/// 打折收费，初始化时，必需输入折扣率，如八折，就是0.8
		/// </summary>
		/// <param name="moneyRebate"></param>
		public CashRebate(string moneyRebate)
		{
			this.moneyRebate = double.Parse(moneyRebate);
		}
		public override double AcceptCash(double money)
		{
			return money * moneyRebate;
		}
	}

	/// <summary>
	/// 返利收费子类
	/// </summary>
	class CashReturn : CashSuper
	{
		private double moneyCondition = 0.0d;
		private double moneyReturn = 0.0d;

		/// <summary>
		/// 返利收费，初始化时必须要输入返利条件和返利值，比如满300返100，则moneyCondition为300，moneyReturn为100
		/// </summary>
		/// <param name="moneyCondition"></param>
		/// <param name="moneyReturn"></param>
		public CashReturn(string moneyCondition, string moneyReturn)
		{
			this.moneyCondition = double.Parse(moneyCondition);
			this.moneyReturn = double.Parse(moneyReturn);
		}

		public override double AcceptCash(double money)
		{
			double result = money;

			// 若大于返利条件，则需要减去返利值
			if (money >= moneyCondition)
			{
				result = money - Math.Floor(money / moneyCondition) * moneyReturn;
			}

			return result;
		}
	}
}
