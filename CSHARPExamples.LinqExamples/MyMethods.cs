using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.LinqExamples {
    internal static class MyMethods {
        public static IEnumerable<TheTypeToFilter> Filter<TheTypeToFilter>(this IEnumerable<TheTypeToFilter> original, Checker<TheTypeToFilter> CheckItem) {
            //return new FilterEnumerator();

            foreach (var item in original) {
                if (CheckItem(item)) {
                    yield return item;
                }
            }
        }

        public static IEnumerable<HuppeDePup> ProjectTo<HatseFlats, HuppeDePup>(this IEnumerable<HatseFlats> collection, Projection<HatseFlats,HuppeDePup> projectTo) {
            foreach (HatseFlats item in collection) {
                yield return projectTo(item);
            }
        }  
        
        
        

    }
}

delegate TOutput Projection<TInput, TOutput>(TInput input);
