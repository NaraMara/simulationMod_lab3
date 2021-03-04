using ENV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Simulation        
    {
        const double dt = 0.01;

        public double angle ;
        public double v0;
        public double y;
        public double m;
        public double S;
        public double sina, cosa;
        public double x;
        public double t;
        public double k;
        public double vx, vy;
        Enviroment enviroment;
        Form1 form;
        public Simulation(double angle, double v0, double y, double m, double s,Form1 form1)
        {
            form = form1;
            this.angle = angle*Math.PI / 180;
            this.v0 = v0;
            this.y = y;
            this.m = m;
            cosa = Math.Cos(angle);
            sina = Math.Sin(angle);
            S = s;
            enviroment=new Enviroment();
            form.Clear();
            t = 0;
            x = 0;
            k = 0.5 * enviroment.C * enviroment.rho * S / m;

            vx = v0 * cosa;
            vy = v0 * sina;
            form.AddDot(x, y);
        }
        public void Tick() 
        {
            t += dt;
            double v = Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (enviroment.g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;

            form.TimeUpdate(t);

            form.AddDot(x, y);

            if (y < 0) form.Stop();
        }
    }
}
