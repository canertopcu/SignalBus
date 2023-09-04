Certainly! Here's a revised version of the README file for your GitHub repository:

---

# SignalBus - Lightweight Unity Event System

SignalBus is a lightweight event system designed for Unity, aimed at simplifying communication between various parts of your game without creating tight dependencies or direct references. It enables you to send custom signals (events) with parameters and allows multiple listeners to subscribe to these signals. By promoting decoupling, SignalBus can lead to cleaner and more maintainable Unity projects.

## Table of Contents

- [Getting Started](#getting-started)
  - [Installation](#installation)
  - [Usage](#usage)
- [Examples](#examples)
- [Contributing](#contributing)
- [License](#license)

## Getting Started

### Installation

1. **Download the SignalBus script**: Begin by downloading the `SignalBus.cs` script from this repository.

2. **Add the script to your Unity project**: Place the `SignalBus.cs` script into your project's `Assets/Scripts` folder or any other convenient location.

### Usage

SignalBus is incredibly straightforward to use in your Unity projects. Follow these steps to integrate it into your game:

1. **Create a Static Class**: Create a static class, such as `SignalBus`, in your Unity project. This class will serve as the central hub for managing and dispatching signals.

2. **Define Signal Handlers**: Define signal handlers (delegate functions) for signals with the number of parameters you require. For instance:

    ```csharp
    public delegate void SignalHandler<T1>(T1 param1);
    public delegate void SignalHandler<T1, T2>(T1 param1, T2 param2);
    ```

3. **Broadcasting Signals**: Within your code, employ `SignalBus.BroadcastSignal` to send signals. Simply specify the signal name and provide the corresponding parameters:

    ```csharp
    SignalBus.BroadcastSignal<float, float>("Move", horizontal, vertical);
    ```

4. **Listening to Signals**: Create classes that need to listen to signals. Within these classes, use `SignalBus.Subscribe` to subscribe to specific signals:

    ```csharp
    private void OnEnable()
    {
        SignalBus.Subscribe<float, float>("Move", Move);
    }

    private void OnDisable()
    {
        SignalBus.Unsubscribe<float, float>("Move", Move);
    }
    ```

5. **Implement Callback Functions**: Implement callback functions that match the delegate signatures for the signals you are subscribing to. These functions will be invoked when the corresponding signals are broadcast:

    ```csharp
    private void Move(float x, float y)
    {
        // Handle the move signal with parameters 'x' and 'y'
        transform.position += new Vector3(x, 0, y) * speed * Time.deltaTime;
    }
    ```

## Examples

For a practical demonstration of SignalBus in action, check out the provided example in the repository:

- [InputManager](Example/InputManager.cs): This script broadcasts a "Move" signal based on user input.
- [PlayerController](Example/PlayerController.cs): This class listens to the "Move" signal and moves the player character accordingly.

Feel free to explore and modify these examples to suit your project's needs.

## Contributing

We welcome contributions to SignalBus! If you have ideas for improvements, bug fixes, or new features, please open an issue or submit a pull request. Check out our [Contribution Guidelines](CONTRIBUTING.md) for more details.

## License

SignalBus is open-source software licensed under the MIT License. For details, please refer to the [LICENSE](LICENSE) file.

---

You can customize this README further by including specific details about your project or any additional sections you find relevant.
