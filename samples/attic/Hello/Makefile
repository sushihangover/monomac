all:
	cp ../../../src/MonoMac.dll* Hello.app/Contents/Resources/
	mcs -debug -main:Demo hello.cs -out:Hello.app/Contents/Resources/Hello.exe -r:System.Drawing -r:Hello.app/Contents/Resources/MonoMac.dll 

run:
	./Hello.app/Contents/MacOS/Hello 
