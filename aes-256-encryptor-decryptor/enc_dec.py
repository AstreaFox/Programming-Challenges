from Crypto import Random
from Crypto.Hash import SHA256
from Crypto.Cipher import AES

def initiateProgram():

    fileName = input("Please enter the filename and extension of the file to load: ")
    userInput = input("To view the file, enter 1, to encode a file, enter 2, or do decode, enter 3: ")

    print()

    if userInput == "1":
        viewFile(fileName)

    elif userInput == "2":
        encodeFile(fileName)

    elif userInput == "3":
        decodeFile(fileName)

    else:
        print("You didn't enter a valid response. Please try again!")
        initiateProgram()

    return fileName



def viewFile(nameOfFile):

    fileName = nameOfFile

    readFile = open(fileName, "r")

    for eachLine in readFile:
        print(eachLine)

    print()

    input("Finished reading? Press ENTER to return to the main menu: ")
    initiateProgram()



def encodeFile(nameOfFile):

    fileName = nameOfFile

    loadFile = open(nameOfFile, "rb")
    clearTextFile = loadFile.read()
    loadFile.close()

    print("You are about to encode: ", fileName)

    clearTextPassword = input("Please enter a password: ")

    hashedKey = SHA256.new(clearTextPassword.encode("utf-8")).digest()
    initialisationVector = Random.new().read(16)
    cleartextLength = len(clearTextFile)
    paddedClearText = clearTextFile + bytes([0] * ((16 - (cleartextLength % 16)) % 16))
    cipherText = AES.new(hashedKey, AES.MODE_CBC, initialisationVector).encrypt(paddedClearText)
    encryptedFileContents = cleartextLength.to_bytes(4, byteorder="little") + initialisationVector + cipherText

    encodedFileName = input("Please enter the name and extension for your encrypted file: ")

    createFile = open(encodedFileName, "wb+")
    createFile.write(encryptedFileContents)
    createFile.close()

    print("You have successfully encoded your file: " + encodedFileName)
    print("You will find it in the same directory as this program.")
    input("Press ENTER to return to the main menu: ")
    initiateProgram()



def decodeFile(nameOfFile):

    fileName = nameOfFile

    loadFile = open(nameOfFile, "rb")
    encryptedFile = loadFile.read()
    loadFile.close()

    print("You are about to encode: ", fileName)
    clearTextPassword = input("Please enter the file's password: ")

    hashedKey = SHA256.new(clearTextPassword.encode("utf-8")).digest()
    clearTextLength = int.from_bytes(encryptedFile[:4], byteorder="little")
    initialisationVector = encryptedFile[4:(4+16)]
    cipherText = encryptedFile[(4+16):]
    plainText = AES.new(hashedKey, AES.MODE_CBC, initialisationVector).decrypt(cipherText)
    decryptedFileContents = plainText[:clearTextLength]

    decodedFileName = input("Please enter the name and extension for your deccrypted file: ")

    createFile = open(decodedFileName, "wb+")
    createFile.write(decryptedFileContents)
    createFile.close()

    print("You have successfully decoded your file: " + decodedFileName)
    print("You will find it in the same directory as this program.")
    input("Press ENTER to return to the main menu: ")
    initiateProgram()



if __name__ == "__main__":

    print("Welcome to this user-driven encryption/decryption program!")
    initiateProgram()