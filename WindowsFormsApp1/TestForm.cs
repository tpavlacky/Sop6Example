﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarnaPropertySheetPreview
{
	public partial class TestForm : Form
	{
		public TestForm()
		{
			InitializeComponent();
			farnaPropertySheetControl2.Init();
		}
	}
}