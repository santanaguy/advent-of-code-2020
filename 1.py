# %%
f = open("./1.txt","r")
# %%
vals = list(map(int, f.readlines()))
# %%
for i in range(0,len(vals)):
        for j in range(i, len(vals)):
            for k in range(j,len(vals)):
                if (vals[i] + vals[j] + vals[k] == 2020):
                    print (vals[i] * vals[j] * vals[k]) 
# %%
