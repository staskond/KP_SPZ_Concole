using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP_consoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            GetBaseBoardInfo BaseBoard = new GetBaseBoardInfo();
            GetHDDInfo HDD = new GetHDDInfo();
            GetProcessorInfo Processor = new GetProcessorInfo();
            GetVideoControllerInfo Video = new GetVideoControllerInfo();

            BaseBoard.GetDeviceInfo();
            HDD.GetDeviceInfo();
            Processor.GetDeviceInfo();
            Video.GetDeviceInfo();

            for (int i = 0; i < BaseBoard.baseBoard.Count(); i++)
            {
                Console.WriteLine("(--------------------------Base Board-----------------)");
                Console.WriteLine(BaseBoard.baseBoard[i].ToString());
                Console.WriteLine("(-----------------------End Base Board-----------------)\n");
            }

            for (int i = 0; i < HDD.hddInfo.Count(); i++)
            {
                Console.WriteLine("(--------------------------HDD-----------------)");
                Console.WriteLine(HDD.hddInfo[i].ToString());
                Console.WriteLine("(-----------------------End HDD----------------)\n");
            }

            for (int i = 0; i < Processor.processorInfo.Count(); i++)
            {
                Console.WriteLine("(--------------------------Processor-----------------)");
                Console.WriteLine(Processor.processorInfo[i].ToString());
                Console.WriteLine("(-----------------------End processor----------------)\n");
            }

            for (int i = 0; i < Video.videoControllers.Count(); i++)
            {
                Console.WriteLine("(--------------------------Base Board-----------------)");
                Console.WriteLine(Video.videoControllers[i].ToString());
                Console.WriteLine("(-----------------------End Base Board-----------------)\n");
            }
            Console.ReadKey();
        }
    }
}
