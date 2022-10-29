# Elijah Robinson

print("Shape Volume Calculator")
print("----------------------------")
print("1. Calculate volume of cone.")
print("2. Calculate volume of cube.")
print("3. Calculate volume of cylinder.")

choice1 = input("Choose 1, 2, or 3: ")

x = 0
while x < 1:

    if choice1 == "1":
        radius_cone = float(input("Enter the cone's radius: "))
        height_cone = float(input("Enter the cone's height: "))
        pi = 3.142
        volume_cone = pi * radius_cone * radius_cone * (height_cone/3)

        print("The volume of the cone is ", volume_cone)

        x = x + 1

    elif choice1 == "2":
        cube_length = float(input("Enter the length of the cone: "))
        cube_Vol = (cube_length * cube_length * cube_length)

        print("The volume of a cube is ", cube_Vol)

        x = x + 1

    elif choice1 == "3":
        pi = 3.142
        radius_Cyl = float(input("Enter the cylinder radius: "))
        height_Cyl = float(input("Enter the cylinder height: "))

        cyl_Vol = (pi * radius_Cyl * radius_Cyl * height_Cyl)

        print("The volume of a cylinder is ", cyl_Vol)

        x = x + 1

    else:
        print("You entered something wrong.")
