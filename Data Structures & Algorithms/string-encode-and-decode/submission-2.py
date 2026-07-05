class Solution:

    def encode(self, strs: List[str]) -> str:
        encodedString = ""
        for _ in strs:
            encodedString+=str(len(_))+"#"+_
        return encodedString

    def decode(self, s: str) -> List[str]:
        decodedString = []
        i = 0
        while i< len(s):
            j = i
            while(s[j]!="#"):
                j+=1
            stringLength = int(s[i:j])
            word = s[j + 1 : j + 1 + stringLength]
            decodedString.append(word)
            i = j + 1 + stringLength
        return decodedString
