# -*- coding=utf-8 -*-
import sys,spacy
def getTypeword(text_list, level, type_word):
    nlp0 = spacy.load("zh_core_web_lg")
    nlp1 = spacy.load("zh_core_web_trf")
    nlp2 = spacy.load("zh_core_web_md")
    nlp3 = spacy.load("zh_core_web_sm")
    result_list = []
    for text in text_list:
        doc0 = nlp0(text)
        company_names = []
        for ent in doc0.ents:
            if ent.label_ == type_word:
                company_names.append(ent.text)
        if company_names == [] and level >= 1:
            doc1 = nlp1(text)
            for ent in doc1.ents:
                if ent.label_ == type_word:
                    company_names.append(ent.text)
            if company_names == [] and level >= 2:
                doc2 = nlp2(text)
                for ent in doc2.ents:
                    if ent.label_ == type_word:
                        company_names.append(ent.text)
                if company_names == [] and level >= 3:
                    doc3 = nlp3(text)
                    for ent in doc3.ents:
                        if ent.label_ == type_word:
                            company_names.append(ent.text)
        result_list.append(company_names)
    return result_list
if __name__ == '__main__':
    try:
        getArgs = sys.argv[1].split("~^__^~")
        main_text0 = str(getArgs[0])
        main_level = str(getArgs[1])
        main_type = str(getArgs[2])
        main_text = main_text0.split("~^_^~")
        main_level = int(main_level)
        main_type = main_type.upper()
        output = getTypeword(main_text, main_level, main_type)
        print(output)
    except Exception as e:
        print(e)