namespace NibbleTools.Interfaces.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
