using Ple;

// Ask what to search for
string query = Menu.Init(args);

// Setup logging
Logging.Init(query);

// Provisions Chromium in the background
var chromium = new Chromium();
await chromium.Init();

// Cleans up Chromium processes on close
AppDomain.CurrentDomain.ProcessExit += delegate{ chromium.Dispose(); };

// Setup polling rate in seconds
int rate = 10;

// Run the loop
var process = new Process(chromium, rate, query);
await process.Init();