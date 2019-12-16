# Unity ML Graph View

## How to build

The binaly is included, if you want to build the latest tflite

### Download the flatbuffers [master source code](https://github.com/google/flatbuffers)

and open `net/FlatBuffers/FlatBuffers.csproj` with VisualStudio and Build DLL. I could use macOS version.

### Install flatbuffer compiler

```bash
# macOS via brew
brew install flatbuffers --HEAD
```

### Build schema for C-Sharp

Checkout the tensorflow [repository](https://github.com/tensorflow/tensorflow). and run following command.

```bash
cd tensorflow/lite/schema/
flatc --csharp schema.fbs
```
