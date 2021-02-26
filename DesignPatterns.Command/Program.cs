using System;
using DesignPatterns.Command.Commands;
using DesignPatterns.Command.Entities;

namespace DesignPatterns.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new SimpleRemoteControl();

            var livingRoomLight = new Light("Living Room");
            var kitchenLight = new Light("Kitchen");
            var garageDoor = new GarageDoor("Garage");
            var stereo = new Stereo("Living Room");

            var livingRoomLightOn = new LightOnCommand(livingRoomLight);
            var livingRoomLightOff = new LightOffCommand(livingRoomLight);
            var kitchenLightOn = new LightOnCommand(kitchenLight);
            var kitchenLightOff = new LightOffCommand(kitchenLight);

            var garageDoorUp = new GarageDoorUpCommand(garageDoor);
            var garageDoorDown = new GarageDoorDownCommand(garageDoor);

            var stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            var stereoOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, garageDoorUp, garageDoorDown);
            remoteControl.SetCommand(3, stereoOnWithCd, stereoOff);

            Console.WriteLine(remoteControl);

            for (var i = 0; i < 4; i++)
            {
                remoteControl.OnButtonWasPushed(i);
                remoteControl.OffButtonWasPushed(i);
            }
            Console.WriteLine();


            var remoteControlWithUndo = new RemoteControlWithUndo();

            var livingRoomLightWithUndo = new Light("Living Room");
            var livingRoomLightOnWithUndo = new LightOnCommand(livingRoomLightWithUndo);
            var livingRoomLightOffWithUndo = new LightOffCommand(livingRoomLightWithUndo);

            remoteControlWithUndo.SetCommand(0, livingRoomLightOnWithUndo, livingRoomLightOffWithUndo);

            Console.WriteLine("With Undo");
            Console.WriteLine(remoteControlWithUndo);

            remoteControlWithUndo.OnButtonWasPushed(0);
            remoteControlWithUndo.OffButtonWasPushed(0);
            remoteControlWithUndo.UndoButtonWasPushed();
            remoteControlWithUndo.OffButtonWasPushed(0);
            remoteControlWithUndo.OnButtonWasPushed(0);
            remoteControlWithUndo.UndoButtonWasPushed();


            //remoteControl.SetCommand(lightOn);
            //remoteControl.ButtonWasPressed();

            //Console.WriteLine();

            //remoteControl.SetCommand(garageDoorOpen);
            //remoteControl.ButtonWasPressed();

            Console.WriteLine();
        }
    }
}
