namespace ShellLauncher2ConfigurationDesigner.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
