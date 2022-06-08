/*! 
@file GridBox.cs
@author Woong Gyu La a.k.a Chris. <juhgiyo@gmail.com>
		<http://github.com/juhgiyo/eppathfinding.cs>
@date July 16, 2013
@brief GridBox Interface
@version 2.0

@section LICENSE

The MIT License (MIT)

Copyright (c) 2013 Woong Gyu La <juhgiyo@gmail.com>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.

@section DESCRIPTION

An Interface for the GridBox Class.

*/

using System;
using System.Drawing;

namespace BattleSnake.PathVisualiser;

enum BoxType { Start, End, Wall, Normal, Obstacle };

class GridBox : IDisposable
{
    public int x, y, width, height;
    public SolidBrush brush;
    public Rectangle boxRec;
    public BoxType boxType;
    public GridBox(int iX, int iY, BoxType iType)
    {
        x = iX;
        y = iY;
        boxType = iType;
        switch (iType)
        {
            case BoxType.Normal:
                brush = new SolidBrush(Color.WhiteSmoke);
                break;
            case BoxType.End:
                brush = new SolidBrush(Color.Blue);
                break;
            case BoxType.Start:
                brush = new SolidBrush(Color.Green);
                break;
            case BoxType.Wall:
                brush = new SolidBrush(Color.Gray);
                break;
            case BoxType.Obstacle:
                brush = new SolidBrush(Color.Black);
                break;

        }
        width = 18;
        height = 18;
        boxRec = new Rectangle(x, y, width, height);
    }

    public void DrawBox(Graphics iPaper, BoxType iType)
    {
        if (iType == boxType)
        {
            boxRec.X = x;
            boxRec.Y = y;
            iPaper.FillRectangle(brush, boxRec);
        }
    }

    public void SwitchBox()
    {
        switch (boxType)
        {
            case BoxType.Normal:
                if (brush != null)
                    brush.Dispose();
                brush = new SolidBrush(Color.Gray);
                boxType = BoxType.Wall;
                break;
            case BoxType.Wall:
                if (brush != null)
                    brush.Dispose();
                brush = new SolidBrush(Color.WhiteSmoke);
                boxType = BoxType.Normal;
                break;

        }
    }

    public void SetObstacle(Graphics graphics)
    {
        if (brush != null)
            brush.Dispose();
        brush = new SolidBrush(Color.Black);
        boxType = BoxType.Obstacle;
        graphics.FillRectangle(brush, boxRec);
    }

    public void SetNormalBox()
    {
        if (brush != null)
            brush.Dispose();
        brush = new SolidBrush(Color.WhiteSmoke);
        boxType = BoxType.Normal;
    }

    public void SetStartBox()
    {
        if (brush != null)
            brush.Dispose();
        brush = new SolidBrush(Color.Green);
        boxType = BoxType.Start;
    }

    public void SetEndBox()
    {
        if (brush != null)
            brush.Dispose();
        brush = new SolidBrush(Color.Red);
        boxType = BoxType.End;
    }


    public void Dispose()
    {
        if (brush != null)
            brush.Dispose();

    }
}
