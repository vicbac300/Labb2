﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labb1.Models;
namespace Labb1.ViewModels
{
	public class OrderViewModel
	{
		public Order Order { get; set; }
		public ApplicationUser User { get; set; }
	}
}
