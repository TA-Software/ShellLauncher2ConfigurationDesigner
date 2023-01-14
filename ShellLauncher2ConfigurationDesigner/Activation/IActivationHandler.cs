namespace ShellLauncher2ConfigurationDesigner.Activation;

public interface IActivationHandler
{
    bool CanHandle(object args);

    Task HandleAsync(object args);
}
