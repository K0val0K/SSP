using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSP3_PAIN.Models;
public class BallModel
{
    public int x { get; set; }
    public int y { get; set; }
    public int dx { get; set; }
    public int dy { get; set; }
    public int SyzeXY { get; set; }
    public int GranX { get; set; }
    public string GranY { get; set; }
    public CancellationTokenSource token { get; set; }
    public Brush Color { get; set; }
    public Task Task { get; set; }
    public List<LineParamModel> parmetrs { get; set; }



    public BallModel(int x, int y, int dx, int dy,int SyzeXY, CancellationTokenSource token, Brush Color, List<LineParamModel> parmetrs)
    {
        this.x = x;
        this.y = y;
        this.dx = dx;
        this.dy = dy;
        this.token = token;
        this.Color = Color;
        this.SyzeXY = SyzeXY;
        this.parmetrs = parmetrs;        
    }
}
