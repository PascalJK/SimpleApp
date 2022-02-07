using SimpleConsole;

var orderProcessor = new OrderProcessor(new ShippingCalculator());
var order = new Order();
orderProcessor.Process(order);
