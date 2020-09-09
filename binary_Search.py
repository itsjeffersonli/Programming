def binarysearch(array, x): 
    l = 0
    r = len(array) 
    r = r - 2 
    while (l <= r): 
        m = l + ((r - 1) // 2) 
  
        res = (x == array[m]) 

        if (res == 0): 
            return m - 1

        if (res > 0): 
            l = m + 1

        else: 
            r = m - 1
  
    return -1

if __name__ == "__main__": 
  
    array = ["Jewel", "Sam", "Cha", "Cloud", "Shine"]; 
    x = str(input("Who Do you want to search for: " + " "))
    result = binarysearch(array, x) 
  
    if (result == -1): 
        print("The Name not present") 
    else: 
        print("Name found at index" ,result) 
    
    print(array)    
