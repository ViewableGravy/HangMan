﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public static class HangMan
    {

        public static void Draw(int wrongGuessesMade)
        {
            Player.Message(new string[] { "", "" });

            switch (wrongGuessesMade)
            {
                case 0:
                    StageZero();
                    break;
                case 1:
                    StageOne();
                    break;
                case 2:
                    StageTwo();
                    break;
                case 3:
                    StageThree();
                    break;
                case 4:
                    StageFour();
                    break;
                case 5:
                    StageFive();
                    break;
                case 6:
                    StageSix();
                    break;
                case 7:
                    StageSeven();
                    break;
                case 8:
                    StageEight();
                    break;
                case 9:
                    StageNine();
                    break;
                case 10:
                    StageTen();
                    break;
                default:
                    break;
            }

        }

        private static void StageOne()
        {
            Player.Message(new string[] {   "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------_________________________-----",
                                            "------------------------------------ " });
        }
        private static void StageTwo()
        {
            Player.Message(new string[] {   "------------------------------------",
                                            "------------------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "------_________________________-----",
                                            "------------------------------------ " });
        }
        private static void StageThree()
        {
            Player.Message(new string[] {   "------------------------------------",
                                            "------------------------------------",
                                            "-------|______________--------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "------_________________________-----",
                                            "------------------------------------ " });
        }
        private static void StageFour()
        {
            Player.Message(new string[] {   "------------------------------------",
                                            "------------------------------------",
                                            "-------|______________--------------",
                                            "-------|-/--------------------------",
                                            "-------|/---------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "------_________________________-----",
                                            "------------------------------------ " });
        }
        private static void StageFive()
        {
            Player.Message(new string[] {   "------------------------------------",
                                            "------------------------------------",
                                            "-------|______________--------------",
                                            "-------|-/-----------|--------------",
                                            "-------|/------------|--------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "------_________________________-----",
                                            "------------------------------------ " });
        }
        private static void StageSix()
        {
            Player.Message(new string[] {   "------------------------------------",
                                            "------------------------------------",
                                            "-------|______________--------------",
                                            "-------|-/-----------|--------------",
                                            "-------|/------------|--------------",
                                            "-------|------------___-------------",
                                            "-------|-----------/---\\------------",
                                            "-------|----------|-----|-----------",
                                            "-------|-----------\\___/------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "------_________________________-----",
                                            "------------------------------------ " });
        }
        private static void StageSeven()
        {
            Player.Message(new string[] {   "------------------------------------",
                                            "------------------------------------",
                                            "-------|______________--------------",
                                            "-------|-/-----------|--------------",
                                            "-------|/------------|--------------",
                                            "-------|------------___-------------",
                                            "-------|-----------/---\\------------",
                                            "-------|----------|-----|-----------",
                                            "-------|-----------\\___/------------",
                                            "-------|-------------|--------------",
                                            "-------|-------------|--------------",
                                            "-------|-------------|--------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "-------|----------------------------",
                                            "------_________________________-----",
                                            "------------------------------------ " });
        }
        private static void StageEight()
        {
            Player.Message(new string[] {   "------------------------------------",
                                            "------------------------------------",
                                            "-------|______________--------------",
                                            "-------|-/-----------|--------------",
                                            "-------|/------------|--------------",
                                            "-------|------------___-------------",
                                            "-------|-----------/---\\------------",
                                            "-------|----------|-----|-----------",
                                            "-------|-----------\\___/------------",
                                            "-------|-------------|--------------",
                                            "-------|-------------|--------------",
                                            "-------|-------------|--------------",
                                            "-------|------------/---------------",
                                            "-------|-----------/----------------",
                                            "-------|----------/-----------------",
                                            "-------|----------------------------",
                                            "------_________________________-----",
                                            "------------------------------------ " });
        }
        private static void StageNine()
        {
            Player.Message(new string[] {   "------------------------------------",
                                            "------------------------------------",
                                            "-------|______________--------------",
                                            "-------|-/-----------|--------------",
                                            "-------|/------------|--------------",
                                            "-------|------------___-------------",
                                            "-------|-----------/---\\------------",
                                            "-------|----------|-----|-----------",
                                            "-------|-----------\\___/------------",
                                            "-------|-------------|--------------",
                                            "-------|---------____|--------------",
                                            "-------|-------------|--------------",
                                            "-------|------------/---------------",
                                            "-------|-----------/----------------",
                                            "-------|----------/-----------------",
                                            "-------|----------------------------",
                                            "------_________________________-----",
                                            "------------------------------------ " });
        }
        private static void StageTen()
        {
            Player.Message(new string[] {   "------------------------------------",
                                            "------------------------------------",
                                            "-------|______________--------------",
                                            "-------|-/-----------|--------------",
                                            "-------|/------------|--------------",
                                            "-------|------------___-------------",
                                            "-------|-----------/---\\------------",
                                            "-------|----------|-----|-----------",
                                            "-------|-----------\\___/------------",
                                            "-------|-------------|--------------",
                                            "-------|---------____|____----------",
                                            "-------|-------------|--------------",
                                            "-------|------------/---------------",
                                            "-------|-----------/----------------",
                                            "-------|----------/-----------------",
                                            "-------|----------------------------",
                                            "------_________________________-----",
                                            "------------------------------------ " });
        }
        private static void StageZero()
        {
            Player.Message(new string[] {   "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------",
                                            "------------------------------------ " });
        }



    }
}
