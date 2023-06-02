def b(a1):
    c = [] 
    trip = ""
    begTrip = ""
    for i in a1:
        if i == "1" or i == "2" or i == "3" or i == "4" or i == "5" or i == "6" or i == "7" or i == "8" or i == "9" or i == "0" or "+" or "-":
            if i == "1" or i == "2" or i == "3" or i == "4" or i == "5" or i == "6" or i == "7" or i == "8" or i == "9" or i == "0":
                if i == "1":
                    trip +=i
                if i == "2":
                    trip +=i
                if i == "3":
                    trip +=i
                if i == "4":
                    trip +=i
                if i == "5":
                    trip +=i
                if i == "6":
                    trip +=i
                if i == "7":
                    trip +=i
                if i == "8":
                    trip +=i
                if i == "9":
                    trip +=i
                if i == "0":
                    trip +=i
            if i == "+" or i == "-":
                begTrip = int(trip)
                c.append(begTrip)
                trip = ""
                c.append(i)

    begTrip = int(trip)
    c.append(begTrip)

    return c
def d(a3):
    HZ = 0
    c = 0
    c1 = 1
    c2 = 2
    tot = True
    while tot:

        if a3[c1] == "+":
            HZ = a3[c] + a3[c2]
        elif a3[c1] == "-":
            HZ = a3[c] - a3[c2]

        a3.pop(2)
        a3.pop(1)
        a3.pop(0)
        a3.insert(0,HZ)

        HZ = 0

        if len(a3) < 3:
            tot = False

    return a3

while True:
    a = input()
    if a == "":
        break
    a2 = b(a)
    if len(a2) < 3:
        print("?")
        break
    else:
        a3 = d(a2)
        print(a3)


# L.pop
# L.insert