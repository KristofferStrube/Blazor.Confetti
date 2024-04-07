namespace KristofferStrube.Blazor.Confetti;

public record struct ConfettiPiece(ConfettiType Type, string Color, int Size, int Milliseconds, (double X, double Y)[] Positions);