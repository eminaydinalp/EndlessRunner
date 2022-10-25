namespace _Game.Scripts.Abstracts
{
    public interface IInputReader
    {
        float HorizontalDirection { get; }
        bool IsJump { get; }
    }
}
