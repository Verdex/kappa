
cc = csc

data = Data/*.cs
actor = Actors/*.cs

all : 
	$(cc) Program.cs Util.cs $(data) $(actor)

clean :
	rm -rf *.exe
