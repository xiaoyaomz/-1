﻿// Decompiled with JetBrains decompiler
// Type: BnyEditor.ListViewEx
// Assembly: BnyEditor_Margin, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D603A8BF-7840-4117-8ECA-12CCC35D8950
// Assembly location: E:\架设\梦幻诛仙\笔记\梦诛工具\BnyEditor带搜索\BnyEditor\BnyEditor.exe

using System.Windows.Forms;

#nullable disable
namespace BnyEditor
{
  public class ListViewEx : ListView
  {
    public ListViewEx()
    {
      this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true);
      this.UpdateStyles();
    }
  }
}
