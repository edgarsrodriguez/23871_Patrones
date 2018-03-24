using _180316_Command_01.FanCommands;
using _180316_Command_01.Receivers;
using _180316_Command_01.RoofLightCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180316_Command_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            /* 1 boton
            SimpleInvoker SimpleInvoker = new SimpleInvoker();
            RoofLight RoofLight = new RoofLight();
            RoofLightOn RoofLightOn = new RoofLightOn();
            RoofLightOn.roofLight = RoofLight;
            SimpleInvoker.SetCommand(RoofLightOn);
            SimpleInvoker.PressButton();*/

            ComplexInvoker ComplexInvoker = new ComplexInvoker();
            RoofLight RoofLight = new RoofLight();
            RoofLightOn RoofLightOn = new RoofLightOn();
            RoofLightOn.RoofLight = RoofLight;
            RoofLightOff RoofLightOff = new RoofLightOff();
            RoofLightOff.RoofLight = RoofLight;
            RoofLightDim RoofLightDim = new RoofLightDim();
            RoofLightDim.RoofLight = RoofLight;

            Fan Fan = new Fan();
            FanHigh FanHigh = new FanHigh();
            FanHigh.Fan = Fan;
            FanMedium FanMedium = new FanMedium();
            FanMedium.Fan = Fan;
            FanLow FanLow = new FanLow();
            FanLow.Fan = Fan;
            FanOff FanOff = new FanOff();
            FanOff.Fan = Fan;

            PartyMode PartyMode = new PartyMode();
            PartyMode.CommandList.Add(FanHigh);
            PartyMode.CommandList.Add(RoofLightOn);

            //ComplexInvoker.SetCommand(RoofLightOn, 0);
            //ComplexInvoker.SetCommand(RoofLightOff, 1);
            //ComplexInvoker.SetCommand(RoofLightDim, 2);
            //ComplexInvoker.SetCommand(FanHigh, 3);
            //ComplexInvoker.SetCommand(FanMedium, 4);
            //ComplexInvoker.SetCommand(FanLow, 5);
            //ComplexInvoker.SetCommand(FanOff, 6);
            ComplexInvoker.SetCommand(PartyMode, 2);

            /*ComplexInvoker.PressButton(0);
            ComplexInvoker.Undo();
            ComplexInvoker.PressButton(1);
            ComplexInvoker.PressButton(2);*/
            //ComplexInvoker.PressButton(3);
            //ComplexInvoker.PressButton(4);
            /*ComplexInvoker.Undo();
            ComplexInvoker.Undo();*/
            ComplexInvoker.PressButton(2);
            ComplexInvoker.Undo();
            //ComplexInvoker.PressButton(6);
            //ComplexInvoker.PressButton(5);
            //ComplexInvoker.PressButton(6);
        }
    }
}
