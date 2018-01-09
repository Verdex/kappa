
cc = csc

data = Data/*.cs
actor = Actors/*.cs
util = Util/*.cs

all : 
	$(cc) Program.cs $(util) $(data) $(actor)

clean :
	rm -rf *.exe
