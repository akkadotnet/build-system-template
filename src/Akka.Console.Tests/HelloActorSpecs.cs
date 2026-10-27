using Akka.Console;
using Xunit;
using TestKitBase = Akka.TestKit.Xunit2.TestKit;

namespace Akka.Console.Tests;

public class HelloActorSpecs : TestKitBase
{
    [Fact]
    public void HelloActor_should_log_each_message_with_an_incrementing_counter()
    {
        var helloActor = Sys.ActorOf(Props.Create(() => new HelloActor()), "hello-actor");

        // HelloActor's observable contract is its log output: "{message} {counter}",
        // where the counter starts at 0 and increments per message.
        EventFilter.Info("hello 0").ExpectOne(() => helloActor.Tell("hello"));
        EventFilter.Info("hello 1").ExpectOne(() => helloActor.Tell("hello"));
        EventFilter.Info("hello 2").ExpectOne(() => helloActor.Tell("hello"));
    }
}
