using System;

namespace Enums
{
    [Flags]
    public enum Wochentage : byte
    {
        Montag      = 1,
        Dienstag    = 2,
        Mittwoch = 4,
        Donnerstag = 8,
        Freitag = 16,
        Samstag = 32,
        Sonntag = 64
    }
}
