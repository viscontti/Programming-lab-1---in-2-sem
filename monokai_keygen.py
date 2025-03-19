from hashlib import md5
import re 

# UUID  
uuid = "fd330f6f-3f41-421d-9fe5-de742d0c54c0"
email = input("email: ")

combined = uuid + email

# Генерация md5 хэша в шестнадцатеричном формате
o = md5(combined.encode('utf-8')).hexdigest()

regex = r".{1,5}"
matches = re.findall(regex, o)

# Форматирование ключа
key = "-".join(matches[:5])

print(key)




