from os import system

def execute(file_path : str) -> None:
    system("python %s"%file_path)
    
# Clear the log
with open("main.log", "w") as f:
    pass

execute("grover_test.py")
execute("graph_test.py")
execute("select_vertex.py")
execute("select_multiple_vertex.py")