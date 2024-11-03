using Microsoft.Extensions.Logging;

namespace ShopSampleWebApi.WebApi.Tests.Helpers
{
    /// <summary>
    /// A test logger implementation for capturing log messages.
    /// </summary>
    /// <typeparam name="T">The type for which this logger is being created.</typeparam>
    public class TestLogger<T> : ILogger<T>
    {
        /// <summary>
        /// Gets the list of logged messages.
        /// </summary>
        public List<string> LoggedMessages { get; } = new List<string>();

        /// <summary>
        /// Begins a logical operation scope.
        /// </summary>
        /// <typeparam name="TState">The type of the state.</typeparam>
        /// <param name="state">The identifier for the scope.</param>
        /// <returns>A disposable object that ends the logical operation scope on dispose.</returns>
        public IDisposable? BeginScope<TState>(TState state) => null;

        /// <summary>
        /// Checks if the given log level is enabled.
        /// </summary>
        /// <param name="logLevel">The log level to check.</param>
        /// <returns>True if the log level is enabled; otherwise, false.</returns>
        public bool IsEnabled(LogLevel logLevel) => true;

        /// <summary>
        /// Logs a message with the specified log level and other parameters.
        /// </summary>
        /// <typeparam name="TState">The type of the state.</typeparam>
        /// <param name="logLevel">The log level.</param>
        /// <param name="eventId">The event ID.</param>
        /// <param name="state">The state to log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="formatter">The function to create a log message.</param>
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            var message = formatter(state, exception);
            LoggedMessages.Add($"{logLevel}: {message}");
        }
    }
}
